import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PageSharedModule } from './shared/page-shared.module';
import { HomeComponent } from './home/home.component';
import { ElementsComponent } from './elements/elements.component';
import { HeaderComponent } from "./shared/header/header.component";
import { FooterComponent } from "./shared/footer/footer.component";

@NgModule({
    declarations: [
        // HomeComponent,
        ElementsComponent
    ],
    exports: [
    // HomeComponent
    ],
    imports: [
        CommonModule,
        HeaderComponent,
        FooterComponent
    ]
})
export class PageModule { }
