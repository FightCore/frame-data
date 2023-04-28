import { Injectable } from '@angular/core';
import { Meta, MetaDefinition } from '@angular/platform-browser';
import { Character, Move } from '@fightcore/models';

@Injectable({
  providedIn: 'root',
})
export class MetaTagService {
  constructor(private meta: Meta) {}

  updateCharacterMetaTags(character: Character): void {
    const title = `${character.name} | FightCore - Melee Frame Data`;
    const description = `Frame data for ${character.name} from Super Smash Bros. Melee`;
    this.generateTags(title, description);
  }

  updateMoveTags(move: Move, character: Character): void {
    const title = `${character.name} ${move.name} | FightCore - Melee Frame Data`;
    const description = `Frame data for ${move.name} from ${character.name} in Super Smash Bros. Melee`;
    this.generateTags(title, description);
  }

  updateForCharacters(): void {
    const title = 'Characters Overview | FightCore - Melee Frame data';
    const description = 'Frame data for all characters in Super Smash Bros. Melee';
    this.generateTags(title, description);
  }

  removeAllTags() {
    const namedTags = ['title', 'description', 'twitter:title', 'twitter:description'];
    const propertyTags = ['og:title', 'og:description'];

    for (const namedTag of namedTags) {
      const existingTag = this.meta.getTag(`name="${namedTag}"`);
      if (existingTag) {
        this.meta.removeTagElement(existingTag);
      }
    }

    for (const propertyTag of propertyTags) {
      const existingTag = this.meta.getTag(`property="${propertyTag}"`);
      if (existingTag) {
        this.meta.removeTagElement(existingTag);
      }
    }
  }

  private updateOrCreateTag(tag: MetaDefinition): void {
    let existingTag: HTMLMetaElement | null = null;
    if (tag.name) {
      existingTag = this.meta.getTag(`name="${tag.name}"`);
    } else if (tag.property) {
      existingTag = this.meta.getTag(`property="${tag.property}"`);
    }

    if (existingTag) {
      this.meta.updateTag(tag);
      return;
    }

    this.meta.addTag(tag);
  }

  private generateTags(title: string, description: string): void {
    const tags = [
      { name: 'title', content: title },
      { name: 'description', content: description },
      { name: 'theme-color', content: '#96153a' },
      { name: 'twitter:title', content: title },
      { name: 'twitter:creator', content: '@FightCoregg' },
      { name: 'twitter:description', content: description },
      { name: 'twitter:card', content: 'summary' },
      { name: 'twitter:site', content: 'https://fightcore.gg' },
    ];

    for (const tag of tags) {
      this.updateOrCreateTag(tag);
    }

    const ogTags = [
      { property: 'og:title', content: title },
      { property: 'og:description', content: description },
      { property: 'og:url', content: 'https://fightcore.gg' },
      { property: 'og:type', content: 'website' },
    ];

    for (const tag of ogTags) {
      this.updateOrCreateTag(tag);
    }
  }
}
