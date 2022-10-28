import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EntryDetailComponent } from './main/pages/entry-detail/entry-detail.component';
import { HomepageComponent } from './main/pages/homepage/homepage.component';
import { LoginComponent } from './main/pages/login/login.component';
import { SignupComponent } from './main/pages/signup/signup.component';

const routes: Routes = [
  {path : "", component : HomepageComponent},
  {path : "login", component : LoginComponent},
  {path : "signup", component : SignupComponent},
  {path : "entry-detail", component : EntryDetailComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
