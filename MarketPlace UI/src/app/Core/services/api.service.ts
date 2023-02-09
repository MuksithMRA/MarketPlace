import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LoadingService } from 'app/Shared/services/loading.service';
import { environment } from 'environments/environment';
import { Observable, catchError, map, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient, private loadingService: LoadingService) { }

  get<T>(path: string, params?: HttpParams, headers?: HttpHeaders): Observable<T> {
    const httpOptions = {
      headers: headers,
      params: params,
    };
    return this.http.get<T>(environment + path, httpOptions).pipe(
      catchError(err => {
        return throwError(() => err);
      }),
    );
  }

  post<T>(path: string, data: any, params?: HttpParams, headers?: HttpHeaders): Observable<T> {
    const httpOptions = {
      headers: headers,
      params: params,
    };
    return this.http.post<T>(environment.apiURL + path, data, httpOptions);

  }

  put<T>(path: string, data: any, params?: HttpParams, headers?: HttpHeaders): Observable<T> {
    const httpOptions = {
      headers: headers,
      params: params,
    };
    return this.http.put<T>(environment + path, data, httpOptions).pipe(
      catchError(err => {
        return throwError(() => err);
      }),
    );
  }

  delete<T>(path: string, params?: HttpParams, headers?: HttpHeaders): Observable<T> {
    const httpOptions = {
      headers: headers,
      params: params,
    };
    return this.http.delete<T>(environment + path, httpOptions).pipe(
      catchError(err => {
        return throwError(() => err);
      }),
    );
  }
}
