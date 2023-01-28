import { Injectable } from '@angular/core';
import { LoadingService } from './loading.service';
import { HttpEvent, HttpHandler, HttpRequest } from '@angular/common/http';
import { Observable, finalize } from 'rxjs';

@Injectable()
export class LoadingInterceptorService {
  activeRequests: number = 0;
  constructor(
    private loadingService: LoadingService
  ) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    if (this.activeRequests == 0) {
      this.loadingService.startLoading();
    }

    this.activeRequests++;
    return next.handle(req).pipe(
      finalize(() => {
        this.activeRequests--;
        if (this.activeRequests == 0) {
          this.loadingService.stopLoading();
        }
      })
    )
  };
}
