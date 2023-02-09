import { Injectable, EventEmitter, Output } from '@angular/core';
import { Observable, catchError, retry, throwError } from 'rxjs';
import { ApiService } from './api.service';
import { LoginResponse } from '../interfaces/login-response';
import { LocalStorageService } from './local-storage.service';
import { StorageKeys } from '../constants/storage-keys';
import { LoadingService } from 'app/Shared/services/loading.service';
import { NotificationService } from 'app/Shared/services/notification.service';
import { ErrorHandelerService } from 'app/Shared/services/error-handeler.service';
import { error } from 'console';
import { HttpErrorResponse } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  @Output() loginResponse: EventEmitter<LoginResponse> = new EventEmitter();

  constructor(
    private apiService: ApiService,
    private localStorageService: LocalStorageService,
    private errorHandelerService: ErrorHandelerService,
    private loadingService: LoadingService
  ) { }

  login(email: string, password: string): Observable<LoginResponse> {
    this.loadingService.startLoading();
    this.apiService.post("User/Login", { email, password })
      .pipe((retry(1), catchError((error: HttpErrorResponse) => this.errorHandelerService.handleError(error))))
      .subscribe((res: any) => {
        this.localStorageService.set(StorageKeys.TOKEN, res['token']);
        this.loginResponse.emit({
          userDTO: res['userDTO'],
          token: res['token'],
          message: res['message'],
          statusCode: res['statusCode']
        });
        console.log("end observe");
        this.loadingService.stopLoading();
      });

    return this.loginResponse;
  }

}
