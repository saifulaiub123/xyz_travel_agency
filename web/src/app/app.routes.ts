import { Routes, RouterModule } from '@angular/router';
import { ElementsComponent } from './pages/elements/elements.component';
import { HomeComponent } from './pages/home/home.component';
import { ServiceComponent } from './pages/service/service.component';
import { AboutComponent } from './pages/about/about.component';
import { ContactComponent } from './pages/contact/contact.component';
import { LoginComponent } from './pages/login/login.component';
import { RegistrationComponent } from './pages/registration/registration.component';
import { SuggessionComponent } from './pages/suggession/suggession.component';

export const routes: Routes = [

  {
    path: '',component: HomeComponent,
  },
  {
    path: 'elements',component: ElementsComponent,
  },
  {
    path: 'service',component: ServiceComponent,
  },
  {
    path: 'about',component: AboutComponent,
  },
  {
    path: 'contact',component: ContactComponent,
  },
  {
    path: 'login',component: LoginComponent,
  },
  {
    path: 'registration',component: RegistrationComponent,
  },
  {
    path: 'suggession',component: SuggessionComponent,
  },
  { path: '**', redirectTo: 'error/404' },
];

