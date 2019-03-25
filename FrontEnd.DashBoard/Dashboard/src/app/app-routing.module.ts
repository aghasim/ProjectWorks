import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './helpers';
import { LoginComponent } from './components';
import { HomeComponent } from './components';
import { AccessDeniedComponent } from './components';

const routes: Routes = [
  { path: '', component: LoginComponent },
  { path: 'access-denied', component: AccessDeniedComponent },
  { path: 'home', component: HomeComponent, canActivate: [AuthGuard] },
  { path: '**', redirectTo: '' }
];

export const AppRoutingModule = RouterModule.forRoot(routes);