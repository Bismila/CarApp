import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { MovingService } from './services/moving.service';
import { HeaderComponent } from './share/header/header.component';
import { FooterComponent } from './share/footer/footer.component';
import { OrderFormComponent } from './share/order-form/order-form.component';
import { PageContentComponent} from './share/page-content/page-content.component';
import { NavbarMenuComponent } from './share/navbar-menu/navbar-menu.component';
import { Ng2PageScrollModule } from 'ng2-page-scroll';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    OrderFormComponent,
    PageContentComponent,
    NavbarMenuComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    Ng2PageScrollModule
  ],
  providers: [MovingService],
  bootstrap: [AppComponent]
})
export class AppModule { }
