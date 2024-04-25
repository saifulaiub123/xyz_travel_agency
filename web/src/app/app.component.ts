import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PageModule } from './pages/page.module';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet,PageModule]
})
export class AppComponent {
  title = 'travel-agency';
}
