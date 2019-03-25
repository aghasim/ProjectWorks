import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { JwtInterceptor, ErrorInterceptor } from './helpers';

import { AppComponent } from './app.component';
import { LoginComponent } from './components';
import { HomeComponent } from './components';
import { AccessDeniedComponent } from './components';

// fake backend
import { fakeBackendProvider } from './helpers';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    AccessDeniedComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    // fake backend provider
    fakeBackendProvider
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }