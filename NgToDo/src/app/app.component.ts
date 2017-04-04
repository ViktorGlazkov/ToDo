import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  private access_token = localStorage.getItem('access_token');
  private expires_in = localStorage.getItem('expires_in');
  private token_type = localStorage.getItem('token_type');
  private userName = localStorage.getItem('userName');
}
