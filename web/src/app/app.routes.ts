import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { ElementsComponent } from './pages/elements/elements.component';
import { HomeComponent } from './pages/home/home.component';

export const routes: Routes = [

  {
    path: 'elements',
    component: ElementsComponent,
  },
  // {
  //   path: 'error',
  //   loadChildren: () =>
  //     import('./modules/errors/errors.module').then((m) => m.ErrorsModule),
  // },
  {
    path: '',
    component: HomeComponent,
  },
  { path: '**', redirectTo: 'error/404' },
];

