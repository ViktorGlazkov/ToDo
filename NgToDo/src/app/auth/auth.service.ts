import {Injectable} from '@angular/core';
import {AuthProvider} from './auth.provider';
import {Router} from '@angular/router';

@Injectable()
export class AuthService {
  private authProvider: AuthProvider;
  private router: Router;

  constructor(router: Router, authProvider: AuthProvider) {
    this.router = router;
    this.authProvider = authProvider;
  }

  public login(email: string, password: string) {
    return this.authProvider.login(email, password).subscribe(response => {
        localStorage.setItem('access_token', response.json().access_token);
        localStorage.setItem('expires_in', response.json().expires_in);
        localStorage.setItem('token_type', response.json().token_type);
        localStorage.setItem('userName', response.json().userName);
        this.router.navigate(['values']);
      },
      error => {
        alert(error.text());
        console.log(error.text());
      });;
  }

  public register(email: string, password: string) {
    return this.authProvider.register(email, password).subscribe(response => {
        this.router.navigate(['Home']);
      },
      error => {
        alert(error.text());
        console.log(error.text());
      });
  }
}
