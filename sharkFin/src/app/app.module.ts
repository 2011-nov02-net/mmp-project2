import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Routes, RouterModule, Router } from '@angular/router';
import {
  OKTA_CONFIG,
  OktaAuthModule,
  OktaCallbackComponent,
  OktaAuthGuard
} from '@okta/okta-angular';

import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { InputComponent } from './components/input/input.component';
import { SignupComponent } from './signup/signup.component';
import { HomeComponent } from './home/home.component';
import { UserComponent } from './user/user.component';
import { LoginComponent } from './login/login.component';
import { PortfolioComponent } from './portfolio/portfolio.component';
import { LeaderboardComponent } from './leaderboard/leaderboard.component';
const config = {
  issuer: 'https://dev-6569763.okta.com/oauth2/default',
  redirectUri: `${window.location.origin}/login/callback`,
  clientId: '0oa312zn8PEAQonOd5d6', 
  scopes: ['openid', 'email'],
  pkce: true,

}



@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    InputComponent,
    SignupComponent,
    HomeComponent,
    UserComponent,
    LoginComponent,
    PortfolioComponent,
    LeaderboardComponent,

  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    OktaAuthModule,
    AppRoutingModule,
  ],
  providers: [
    { provide: OKTA_CONFIG, useValue: config }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
