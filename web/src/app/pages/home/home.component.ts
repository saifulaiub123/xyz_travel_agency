import { Component } from '@angular/core';
import { PageSharedModule } from '../shared/page-shared.module';
import { HeaderComponent } from "../shared/header/header.component";
import { BodyComponent } from "../shared/body/body.component";
import { FooterComponent } from "../shared/footer/footer.component";
import { CommonModule } from '@angular/common';


@Component({
    selector: 'app-home',
    standalone: true,
    templateUrl: './home.component.html',
    styleUrl: './home.component.css',
    imports: [CommonModule, HeaderComponent, BodyComponent, FooterComponent]
})
export class HomeComponent {

}
