import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginResponse } from 'app/Core/interfaces/login-response';
import { AuthenticationService } from 'app/Core/services/authentication.service';
import { MessageService } from 'primeng/api/messageservice';

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


  constructor(private router: Router, private fb: FormBuilder, private authService: AuthenticationService) { }

  ngOnInit(): void {
  }

  onSignIn(): void {
    this.authService.login(this.loginform.value.email, this.loginform.value.password).subscribe((response: LoginResponse) => {
      if (response.statusCode == 200) {
        this.router.navigate(['/admin']);
      }
    });
    if (this.loginform.invalid) {
      this.loginform.markAllAsTouched();
      return;
    }
  }



}
