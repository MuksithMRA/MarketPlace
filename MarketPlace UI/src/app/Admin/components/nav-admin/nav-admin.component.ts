import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { StorageKeys } from 'app/Core/constants/storage-keys';
import { LocalStorageService } from 'app/Core/services/local-storage.service';

@Component({
  selector: 'app-nav-admin',
  templateUrl: './nav-admin.component.html',
  styleUrls: ['./nav-admin.component.scss']
})
export class NavAdminComponent implements OnInit {
  @ViewChild('sidenav')
  sidenav?: ElementRef;
  showProfileDropdown: boolean = false;

  constructor(private router: Router, private localStorageService: LocalStorageService) { }

  ngOnInit(): void {

  }

  onProfileDropdown(): void {
    this.showProfileDropdown = !this.showProfileDropdown;
  }

  onLogout(): void {
    this.localStorageService.remove(StorageKeys.TOKEN);
    this.router.navigate(['/login']);
    this.showProfileDropdown = false;
  }



}
