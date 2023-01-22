import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-common-validation-message',
  templateUrl: './common-validation-message.component.html',
  styleUrls: ['./common-validation-message.component.scss']
})
export class CommonValidationMessageComponent implements OnInit {

  @Input() controlName: string = '';
  @Input() errors: Object = {};
  hasError: boolean = false;
  @Input() formGroup: FormGroup = new FormGroup({});

  constructor() {
  }

  ngOnInit(): void {
  }

}
