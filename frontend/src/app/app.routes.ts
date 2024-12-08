import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: 'auth',
    loadChildren: () => import('../app/features/auth/auth.module').then((m) => m.AuthModule)
  },

  { path: '**', redirectTo: '' }
];
