import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginform = this.fb.group({
    email: ['', Validators.required, Validators.email],
    password: ['', Validators.required],
  });


  constructor(private router: Router, private fb: FormBuilder) { }

  ngOnInit(): void {
  }

  onSignIn(): void {
    if (this.loginform.invalid) {
      this.loginform.markAllAsTouched();
      return;
    }
    //this.router.navigate(['/admin']);
    alert(JSON.stringify(this.loginform.value));
  }



}
