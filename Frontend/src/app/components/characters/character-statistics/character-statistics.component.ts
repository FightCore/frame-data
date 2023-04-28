import { Component, Input, OnInit } from '@angular/core';
import { Character } from 'src/app/models/character';

@Component({
  selector: 'app-character-statistics',
  templateUrl: './character-statistics.component.html',
  styleUrls: ['./character-statistics.component.scss'],
})
export class CharacterStatisticsComponent implements OnInit {
  @Input() frameDataCharacter?: Character;
  statistics?: any[];
  ngOnInit(): void {
    const stats = this.frameDataCharacter!.characterStatistics;
    this.statistics = [
      { name: 'Characters.Attributes.Weight', value: stats.weight },
      { name: 'Characters.Attributes.Gravity', value: stats.gravity },
      { name: 'Characters.Attributes.WalkSpeed', value: stats.walkSpeed },
      { name: 'Characters.Attributes.RunSpeed', value: stats.runSpeed },
      {
        name: 'Characters.Attributes.WavedashLengthRank',
        value: stats.waveDashLengthRank,
      },
      {
        name: 'Characters.Attributes.PLAIntangibilityFrames',
        value: stats.plaIntangibilityFrames,
      },
      { name: 'Characters.Attributes.JumpSquat', value: stats.jumpSquat },
      {
        name: 'Characters.Attributes.CanWallJump',
        value: stats.canWallJump ? 'Yes' : 'No',
      },
      { name: 'Characters.Attributes.Notes', value: stats.notes },
    ].filter((stat) => stat.value !== (null || undefined) && stat.value !== '');
  }

  sortData(event: unknown): void {}
}
