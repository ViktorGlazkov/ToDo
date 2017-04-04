import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions } from '@angular/http';

@Injectable()
export class TaskProvider {
  private http: Http;

  constructor(http: Http) {
    this.http = http;
  }

  public updateTaskList() {
    const url = 'http://localhost:20133/api/task';
    const headers = new Headers({
      'Content-Type': 'applicationjson',
      'Authorization': 'Bearer ' + localStorage.getItem('access_token')
    });

    const options = new RequestOptions({ headers: headers });

    return this.http.get(url, options);
  }
}
