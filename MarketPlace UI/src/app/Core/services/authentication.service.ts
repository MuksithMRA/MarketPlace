import { Injectable, EventEmitter, Output } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { LoginResponse } from '../interfaces/login-response';
import { LocalStorageService } from './local-storage.service';
import { StorageKeys } from '../constants/storage-keys';
import { NotificationService } from './notification.service';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  @Output() loginResponse: EventEmitter<LoginResponse> = new EventEmitter();

  constructor(
    private apiService: ApiService,
    private localStorageService: LocalStorageService,
    private notificationService: NotificationService
  ) { }

  login(email: string, password: string): Observable<LoginResponse> {
    this.apiService.post("User/Login", { email, password })
      .pipe(
      
        )
          .subscribe((response: any) => {
            const res = response['result'];

            if (res['statusCode'] == 200) {
              this.localStorageService.set(StorageKeys.TOKEN, res['token']);
              this.loginResponse.emit({
                userDTO: res['userDTO'],
                token: res['token'],
                message: res['message']
              })
            } else {
              console.log(res['message']);
              this.notificationService.showSuccess(res['message']);
            }
          });
    return this.loginResponse;
  }

}
