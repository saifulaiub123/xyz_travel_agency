import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { HeaderComponent } from "../shared/header/header.component";
import { FooterComponent } from "../shared/footer/footer.component";
import { FormGroup, FormBuilder, FormControl, Validators, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AccountService } from '../../core/services/account.service';
import { HttpClientModule } from '@angular/common/http';
import { catchError } from 'rxjs';
import { Router } from '@angular/router';

@Component({
    selector: 'app-login',
    standalone: true,
    templateUrl: './login.component.html',
    styleUrl: './login.component.css',
    imports: [
      CommonModule,
      HeaderComponent,
      FooterComponent,
      ReactiveFormsModule,
      FormsModule,
      HttpClientModule
    ]
})

export class LoginComponent implements OnInit {
  loginForm!: FormGroup;
  registrationForm!: FormGroup;

  showLoginForm!: boolean;
  loginFailed: boolean = false;
  registrationError: boolean = false;

  constructor(
    private fb: FormBuilder,
    private _accountService: AccountService,
    private router: Router,
  ) { }
  ngOnInit(): void {
    this.initForm();
    this.showLoginForm = true;
  }

  get formControls()  {
    return this.loginForm.controls;
  }
  initForm()
  {
    this.loginForm =  this.fb.group({
      email: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required]),
    })

    this.registrationForm =  this.fb.group({
      name: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required]),
      reEnterPassword: new FormControl('', [Validators.required]),
      phoneNumber: new FormControl('', [Validators.required]),
    })
  }
  isRequired(field: string){
    return this.formControls[field].invalid && (this.formControls[field].dirty || this.formControls[field].touched)
  }

  login()
  {
    if(!this.loginForm.valid)
    {
      return
    }
    this._accountService.login(this.loginForm.value).pipe(
      catchError((err: any) => {
        this.loginFailed = true;
        return ''
      }
    )).subscribe((res: any)=> {
      this.loginFailed = false;
      localStorage.setItem("userData", JSON.stringify(res));
      this.router.navigateByUrl('/user/dashboard');
    })
  }

  registration()
  {
    if(this.registrationForm.controls['password'].value !== this.registrationForm.controls['reEnterPassword'].value)
    {
      return;
    }
    if(!this.registrationForm.valid)
    {
      return
    }
    this._accountService.registration(this.registrationForm.value).pipe(
      catchError((err: any) => {
        this.registrationError = true;
        return '';
      }
    )).subscribe((data: any)=> {
      this.registrationError = false;
      this.registrationForm.reset();
      this.showLoginForm = true;
    })
  }
}
