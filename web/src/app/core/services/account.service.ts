
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
    return this.http.post(`${this.url}/Auth/Login`,model,{ headers : this.headers });
  }
  registration(model: any): Observable<any>
  {
    return this.http.post(`${this.url}/Auth/registration`,model,{ headers : this.headers });
  }
  submitSuggession(model: any): Observable<any>
  {
    return this.http.post(`${this.url}/Suggession/SubmitSuggession`,model,{ headers : this.headers });
  }
}
