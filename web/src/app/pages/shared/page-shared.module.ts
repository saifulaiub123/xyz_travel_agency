import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { BodyComponent } from './body/body.component';

@NgModule({
  declarations: [
    // FooterComponent,
    // HeaderComponent,
    // BodyComponent
  ],
  exports:
  [
    // FooterComponent,
    // HeaderComponent,
    // BodyComponent
  ],
  imports: [
    CommonModule,
  ]
})
export class PageSharedModule { }
