import {Component} from '@angular/core';
import {AuthService} from './auth.service';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html'
})

export class AuthComponent {
  public username: string;
  public password: string;
  public email: string;

  private authService: AuthService;

  constructor(authService: AuthService) {
    this.authService = authService;
  }

  public login() {
    this.authService.login(this.email, this.password);
  }

  public register() {
    this.authService.register(this.email, this.password);
  }
}
