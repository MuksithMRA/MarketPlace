import { AfterViewInit, ChangeDetectorRef, Component, ElementRef, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { LoadingService } from 'app/Shared/services/loading.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-loading',
  templateUrl: './loading.component.html',
  styleUrls: ['./loading.component.scss']
})
export class LoadingComponent implements OnInit, AfterViewInit, OnDestroy {
  loadingSubscription: Subscription = new Subscription();

  constructor(
    private loadingService: LoadingService,
    private _elmRef: ElementRef,
    private _changeDetectorRef: ChangeDetectorRef
  ) {
  }


  ngAfterViewInit(): void {
    this._elmRef.nativeElement.style.display = 'none';
    this.loadingSubscription = this.loadingService.loading.pipe().subscribe((loading: boolean) => {
      this._elmRef.nativeElement.style.display = loading ? 'block' : 'none';
      this._changeDetectorRef.detectChanges();
    });
  }
  ngOnDestroy(): void {
    this.loadingSubscription.unsubscribe();
  }

  ngOnInit(): void {

  }

}
