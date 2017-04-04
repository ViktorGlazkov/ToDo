import {Injectable} from '@angular/core';
import {Http, Headers, RequestOptions} from '@angular/http';

@Injectable()
export class AuthProvider {
  private http: Http;

  constructor(http: Http) {
    this.http = http;
  }

  public login(email: string, password: string) {
    const url = 'http://localhost:20133/Token';
    const body = 'username=' + email + '&password=' + password + '&grant_type=password';
    const headers = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' });
    const options = new RequestOptions({ headers: headers });

    return this.http.post(url, body, options);
  }

  public register(email: string, password: string) {
    const url = 'http://localhost:20133/api/Account/Register';
    const body = {
      Email: email,
      Password: password
    };
    const headers = new Headers({ 'Content-Type': 'application/json' });
    const options = new RequestOptions({ headers: headers });

    return this.http.post(url, body, options);
  }
}
