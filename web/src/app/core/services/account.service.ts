
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  url: string = environment.apiUrl;
  private headers = new HttpHeaders({
    'Access-Control-Allow-Origin': '*'
  });

  constructor(private http: HttpClient) { }

  login(model: any): Observable<any>
  {
    return this.http.post(`${this.url}/Account/Login`,model,{ headers : this.headers });
  }
  registration(model: any): Observable<any>
  {
    return this.http.post(`${this.url}/Account/registration`,model,{ headers : this.headers });
  }
  submitSuggession(model: any): Observable<any>
  {
    return this.http.post(`${this.url}/Account/submitSuggession`,model,{ headers : this.headers });
  }
}
