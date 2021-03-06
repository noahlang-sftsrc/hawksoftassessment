import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class APIService {
  private headers: HttpHeaders;
  private accessPointUrl: string = 'https://localhost:44391/api/contacts';

  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
  }

  public get() {
    // Get all contacts
    return this.http.get(this.accessPointUrl, {headers: this.headers});
  }

  public add(payload) {
    return this.http.post(this.accessPointUrl + "/add", payload, {headers: this.headers});
  }

  public remove(payload) {
    return this.http.delete(this.accessPointUrl + '/' + payload.id, {headers: this.headers});
  }

  public update(payload) {
    return this.http.put(this.accessPointUrl + '/' + payload.id, payload, {headers: this.headers});
  }
}