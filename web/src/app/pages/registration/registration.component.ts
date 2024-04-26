import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ReactiveFormsModule, FormsModule, FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { AccountService } from '../../core/services/account.service';
import { FooterComponent } from '../shared/footer/footer.component';
import { HeaderComponent } from '../shared/header/header.component';

@Component({
  selector: 'app-registration',
  standalone: true,
  imports: [CommonModule, HeaderComponent, FooterComponent, ReactiveFormsModule, FormsModule, HttpClientModule ],
  templateUrl: './registration.component.html',
  styleUrl: './registration.component.css'
})
export class RegistrationComponent implements OnInit {

  registrationForm!: FormGroup;

  constructor(
    private fb: FormBuilder,
    private _accountService: AccountService
  ) { }
  ngOnInit(): void {
    this.initForm();
  }

  get formControls()  {
    return this.registrationForm.controls;
  }
  initForm()
  {
    this.registrationForm =  this.fb.group({
      email: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required]),
      reEnterPassword: new FormControl('', [Validators.required]),
      phoneNumber: new FormControl('', [Validators.required]),
    })
  }
  isRequired(field: string){
    return this.formControls[field].invalid && (this.formControls[field].dirty || this.formControls[field].touched)
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
    this._accountService.registration(this.registrationForm.value).subscribe((res: any) =>
    {

    })
  }
}
