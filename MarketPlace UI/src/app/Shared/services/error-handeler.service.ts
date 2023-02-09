import { Injectable } from '@angular/core';
import { NotificationService } from './notification.service';
import { LoadingService } from './loading.service';
import { throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ErrorHandelerService {

  constructor(
    private notificationService: NotificationService,
    private loadingService: LoadingService
  ) { }

  handleError(error: any) {
    this.loadingService.stopLoading();
    this.notificationService.showError(error.error.message);
    return throwError(() => error);
  }
}
