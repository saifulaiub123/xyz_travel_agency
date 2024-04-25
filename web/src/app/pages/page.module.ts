import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PageSharedModule } from './shared/page-shared.module';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    HomeComponent
  ],
  exports:
  [
    HomeComponent
  ],
  imports: [
    CommonModule,
    PageSharedModule
  ]
})
export class PageModule { }
