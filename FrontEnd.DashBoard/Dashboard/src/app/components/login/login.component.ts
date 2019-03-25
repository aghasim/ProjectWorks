import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { first } from 'rxjs/operators';

import { AlertService, AuthenticationService } from '../../services';

@Component({templateUrl: 'login.component.html'})
export class LoginComponent implements OnInit {
    returnUrl: string;
    username: string;
    filialId: number;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private authenticationService: AuthenticationService,
        private alertService: AlertService
    ) {
        if (this.authenticationService.currentUserValue) { 
            this.router.navigate(['/']);
        }
    }

    ngOnInit() {
        this.returnUrl = this.route.snapshot.queryParams['returnUrl'];
        this.submit();
    }

    submit() {
        this.authenticationService.login(this.username, this.filialId)
            .pipe(first())
            .subscribe(
                data => {
                    if(data) {
                        if(this.returnUrl) {
                            this.router.navigate([this.returnUrl]);
                        } else {
                            this.router.navigate(['/home']);
                        }
                    } else {
                        this.router.navigate(['/access-denied']);
                    }
                },
                error => {
                    this.alertService.error(error);
                });
    }
}