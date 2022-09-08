import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CharacterComponent } from './components/characters/character/character.component';
import { CharactersComponent } from './components/characters/characters/characters.component';
import { CompareToolComponent } from './components/moves/compare-tool/compare-tool.component';
import { MoveComponent } from './components/moves/move/move.component';
import { MovesComponent } from './components/moves/moves/moves.component';

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
  {
    path: 'moves',
    component: MovesComponent,
  },
  {
    path: 'compare-tool',
    component: CompareToolComponent,
  },
  { path: '**', redirectTo: 'characters' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'top', initialNavigation: 'enabledBlocking' })],
  exports: [RouterModule],
})
export class AppRoutingModule {}
