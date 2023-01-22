import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-admin',
  templateUrl: './nav-admin.component.html',
  styleUrls: ['./nav-admin.component.scss']
})
export class NavAdminComponent implements OnInit {
  @ViewChild('sidenav')
  sidenav?: ElementRef;
  showProfileDropdown: boolean = false;

  constructor(private router: Router) { }

  ngOnInit(): void {

  }

  onProfileDropdown(): void {
    this.showProfileDropdown = !this.showProfileDropdown;
  }

  onLogout(): void {
    this.router.navigate(['/login']);
    this.showProfileDropdown = false;
  }



}
