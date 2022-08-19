import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CharacterComponent } from './components/characters/character/character.component';
import { CharactersComponent } from './components/characters/characters/characters.component';
import { MoveComponent } from './components/moves/move/move.component';

const routes: Routes = [
  {
    path: 'characters',
    component: CharactersComponent,
  },
  {
    path: 'characters/:characterId/:characterName',
    component: CharacterComponent,
  },
  {
    path: 'characters/:characterId/:characterName/moves/:moveId/:moveName',
    component: MoveComponent,
  },
  { path: '**', redirectTo: 'characters' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
