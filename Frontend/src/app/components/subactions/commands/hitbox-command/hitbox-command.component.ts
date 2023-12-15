import { Component } from '@angular/core';
import { HitboxCommand } from 'src/app/models/commands/hitbox-command';
import { CommandComponent } from '../command.component';

@Component({
  selector: 'app-hitbox-command',
  templateUrl: './hitbox-command.component.html',
  styleUrls: ['./hitbox-command.component.scss'],
})
export class HitboxCommandComponent extends CommandComponent<HitboxCommand> {}
