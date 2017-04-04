import {Routes} from '@angular/router';
import {AuthComponent} from './auth/auth.component';
import {ValuesComponent} from './task/task.component';

const routes: Routes = [
  { path: 'values', component: ValuesComponent },
  { path: 'auth', component: AuthComponent },
  { path: '', redirectTo: '/auth', pathMatch: 'full' }
];

export const appRoutes = routes;
