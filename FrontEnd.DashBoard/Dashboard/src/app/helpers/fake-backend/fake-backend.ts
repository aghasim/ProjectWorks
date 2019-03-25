import { Injectable } from '@angular/core';
import { HttpRequest, HttpResponse, HttpHandler, HttpEvent, HttpInterceptor, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { delay, mergeMap, materialize, dematerialize } from 'rxjs/operators';

@Injectable()
export class FakeBackendInterceptor implements HttpInterceptor {

    constructor() { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        let users: any[] = JSON.parse(localStorage.getItem('users')) || [];

        return of(null).pipe(mergeMap(() => {
            if (request.url.endsWith('/users/authenticate') && request.method === 'POST') {

              let fakeUser = {
                id: 1,
                filialId: 1,
                username: 'fake-user-username',
                token: 'fake-jwt-token'
              };
              // return fake user
              return of(new HttpResponse({ status: 200, body: fakeUser }));
            }

            return next.handle(request);
        }))
        .pipe(materialize())
        .pipe(delay(500))
        .pipe(dematerialize());
    }
  }

export let fakeBackendProvider = {
    provide: HTTP_INTERCEPTORS,
    useClass: FakeBackendInterceptor,
    multi: true
};