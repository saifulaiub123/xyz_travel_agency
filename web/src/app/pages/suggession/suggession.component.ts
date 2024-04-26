import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FooterComponent } from "../shared/footer/footer.component";
import { HeaderComponent } from "../shared/header/header.component";
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AccountService } from '../../core/services/account.service';
import { catchError } from 'rxjs';
import { NgbAlert, NgbAlertModule } from '@ng-bootstrap/ng-bootstrap';
@Component({
    selector: 'app-suggession',
    standalone: true,
    templateUrl: './suggession.component.html',
    styleUrl: './suggession.component.css',
    imports: [
      CommonModule,
      FooterComponent,
      HeaderComponent,
      ReactiveFormsModule,
      FormsModule,
      HttpClientModule,
      NgbAlert
    ]
})
export class SuggessionComponent implements OnInit {
  suggessionForm!: FormGroup;
  suggessionFormError: boolean = false;
  showSuccessMessage: boolean = false;
  constructor(
    private _accountService: AccountService,
    private fb: FormBuilder,
  ) { }

  ngOnInit(): void {
    this.initForm();
  }

  initForm()
  {
    this.suggessionForm =  this.fb.group({
      tripDestination: new FormControl('', [Validators.required]),
      placeToVisit: new FormControl('', [Validators.required]),
      accomodationSuggession: new FormControl('', []),
      travelType: new FormControl('', [Validators.required]),
      dining: new FormControl('', []),
      averageMoneySpent: new FormControl('', [Validators.required]),
      comments: new FormControl('', []),
    })
  }
  submit()
  {

      if(!this.suggessionForm.valid)
      {
        return
      }
      this._accountService.submitSuggession(this.suggessionForm.value).pipe(
        catchError((err: any) => {
          this.suggessionFormError = true;
          this.showSuccessMessage = false;
        return '';
        }
      )).subscribe((data: any)=> {
        this.suggessionForm.reset();
        this.suggessionFormError = false;
        this.showSuccessMessage = true;
      })
  }
  close() {
    this.showSuccessMessage = false;
	}
}
