import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { TaskListComponent } from './component/list/task-list.component';
import { TaskDetailComponent } from './component/detail/task-detail.component';

const taskRoutes: Routes = [
  { path: 'tasks', component: TaskListComponent },
  { path: 'tasks/:id', component: TaskDetailComponent },
  { path: '', redirectTo: '/tasks', pathMatch: 'full' }
];

@NgModule({
  imports: [
    RouterModule.forRoot(taskRoutes)
  ],
  exports: [
    RouterModule
  ]
})

export class TaskRoutingModule {}
export const routingComponents = [
  TaskListComponent,
  TaskDetailComponent
];
