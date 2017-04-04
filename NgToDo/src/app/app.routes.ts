import {Routes} from '@angular/router';
import {AuthComponent} from './auth/auth.component';
import {TaskComponent} from './task/task.component';

const routes: Routes = [
  { path: 'tasks', component: TaskComponent },
  { path: 'auth', component: AuthComponent },
  { path: '', redirectTo: '/auth', pathMatch: 'full' }
];

export const appRoutes = routes;
