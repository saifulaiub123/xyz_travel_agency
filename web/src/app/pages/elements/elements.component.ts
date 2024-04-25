import { Component } from '@angular/core';
import { HeaderComponent } from '../shared/header/header.component';
import { FooterComponent } from '../shared/footer/footer.component';

@Component({
  selector: 'app-elements',
  standalone: true,
  templateUrl: './elements.component.html',
  styleUrl: './elements.component.css',
  imports: [HeaderComponent, FooterComponent]
})
export class ElementsComponent {

}
