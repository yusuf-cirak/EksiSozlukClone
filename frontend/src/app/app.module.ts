import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {MatIconModule} from '@angular/material/icon';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainLayoutComponent } from './shared/layouts/main/mainlayout.component';
import { NavbarComponent } from './shared/components/navbar/navbar.component';
import { FooterComponent } from './shared/components/footer/footer.component';
import { HomepageComponent } from './main/pages/homepage/homepage.component';
import { EntryListComponent } from './main/components/entry-list/entry-list.component';
import { EntryComponent } from './main/components/entry/entry.component';
import { LoginComponent } from './main/pages/login/login.component';
import { SignupComponent } from './main/pages/signup/signup.component';
import { FixedEntryListComponent } from './main/components/fixed-entry-list/fixed-entry-list.component';
import { EntryDetailComponent } from './main/pages/entry-detail/entry-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    MainLayoutComponent,
    NavbarComponent,
    FooterComponent,
    HomepageComponent,
    EntryListComponent,
    EntryComponent,
    LoginComponent,
    SignupComponent,
    FixedEntryListComponent,
    EntryDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
