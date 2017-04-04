import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { AuthComponent } from './auth/auth.component';
import { MaterialModule } from '@angular/material';

import { RouterModule } from '@angular/router';
import { appRoutes } from './app.routes';
import { AuthService } from './auth/auth.service';
import { AuthProvider } from './auth/auth.provider';
import {TaskProvider} from './task/task.provider';
import {TaskService} from './task/task.service';
import {TaskComponent} from './task/task.component';

@NgModule({
  declarations: [
    AppComponent,
    AuthComponent,
    TaskComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    MaterialModule,

    RouterModule.forRoot(appRoutes, {
      useHash: true
    })
  ],
  providers: [
    AuthService,
    AuthProvider,
    TaskProvider,
    TaskService
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }
