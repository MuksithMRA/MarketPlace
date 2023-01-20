import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-nav-admin',
  templateUrl: './nav-admin.component.html',
  styleUrls: ['./nav-admin.component.scss']
})
export class NavAdminComponent implements OnInit {
  @ViewChild('sidenav')
  sidenav?: ElementRef;

  constructor() { }

  ngOnInit(): void {
    console.log(this.sidenav?.nativeElement.offsetWidth);
  }

}
