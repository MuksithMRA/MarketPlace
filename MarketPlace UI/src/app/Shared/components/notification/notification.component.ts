import { Component, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';

@Component({
  selector: 'app-notification',
  templateUrl: './notification.component.html',
  styleUrls: ['./notification.component.scss']
})
export class NotificationComponent implements OnInit {

  constructor(private messageService: MessageService) { }

  ngOnInit(): void {

  }

  onDelete() {
    this.messageService.clear();
  }

}
