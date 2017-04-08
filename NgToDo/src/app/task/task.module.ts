import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { TaskService } from './task.service';
import { TaskProvider } from './task.provider';
import { routingComponents, TaskRoutingModule } from './task-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { AlertModule } from 'ng2-bootstrap';

@NgModule({
  declarations: [
    routingComponents
  ],
  imports: [
    HttpModule,
    BrowserModule,
    AlertModule.forRoot(),

    TaskRoutingModule
  ],
  providers: [
    TaskProvider,
    TaskService
  ]
})

export class TaskModule { }
