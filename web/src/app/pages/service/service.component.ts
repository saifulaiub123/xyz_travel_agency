import { Component } from '@angular/core';
import { HeaderComponent } from "../shared/header/header.component";
import { FooterComponent } from "../shared/footer/footer.component";
import { CommonModule } from '@angular/common';

@Component({
    selector: 'app-service',
    standalone: true,
    templateUrl: './service.component.html',
    styleUrl: './service.component.css',
    imports: [CommonModule, HeaderComponent, FooterComponent]
})
export class ServiceComponent {

}
