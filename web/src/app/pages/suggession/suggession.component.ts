import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FooterComponent } from "../shared/footer/footer.component";
import { HeaderComponent } from "../shared/header/header.component";
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
    selector: 'app-suggession',
    standalone: true,
    templateUrl: './suggession.component.html',
    styleUrl: './suggession.component.css',
    imports: [CommonModule, FooterComponent, HeaderComponent]
})
export class SuggessionComponent implements OnInit {
  loginForm!: FormGroup;

  constructor(
    private fb: FormBuilder
  ) { }
  ngOnInit(): void {
    this.initForm();
  }

  initForm()
  {
    this.loginForm =  this.fb.group({
      username: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required]),
    })
  }
}
