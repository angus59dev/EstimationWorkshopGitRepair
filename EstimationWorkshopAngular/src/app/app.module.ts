import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RunningWorkshopComponent } from './components/running-workshop/running-workshop.component';
import { HeaderComponent } from './components/header/header.component';
import { SignupComponent } from './components/user/signup/signup.component';
import { SigninComponent } from './components/user/signin/signin.component';
import { HomeComponent } from './components/home/home.component';
import { UnknownpageComponent } from './components/unknownpage/unknownpage.component';

@NgModule({
  declarations: [
    AppComponent,
    RunningWorkshopComponent,
    HeaderComponent,
    SignupComponent,
    SigninComponent,
    HomeComponent,
    UnknownpageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
