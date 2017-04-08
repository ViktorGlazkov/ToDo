import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { AuthComponent } from './auth/auth.component';
import { MaterialModule } from '@angular/material';

import { RouterModule } from '@angular/router';
import { AuthService } from './auth/auth.service';
import { AuthProvider } from './auth/auth.provider';
import { AppRoutingModule, routingComponents } from './app-routing.module';
import { TaskModule } from './task/task.module';
import { NavbarComponent } from './component/navbar/navbar.component';

@NgModule({
  declarations: [
    routingComponents,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    MaterialModule,

    TaskModule,

    AppRoutingModule
  ],
  providers: [
    AuthService,
    AuthProvider
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }
