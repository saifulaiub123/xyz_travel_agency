import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { PageModule } from './pages/page.module';
import { CommonModule } from '@angular/common';
import { HomeComponent } from "./pages/home/home.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [CommonModule, RouterOutlet, RouterLink, HomeComponent]
})
export class AppComponent {
  title = 'travel-agency';
}
