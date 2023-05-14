import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { Loader } from '@fightcore/search/lib/loader';
import { Search } from '@fightcore/search/lib/search';
import { Character } from '@fightcore/models';
import { selectCharacters } from 'src/app/store/frame-data/frame-data.selectors';
import { first } from 'rxjs';
import { SearchResult } from '@fightcore/search/lib/search-result';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-search-dialog',
  templateUrl: './search-dialog.component.html',
  styleUrls: ['./search-dialog.component.scss'],
})
export class SearchDialogComponent {
  searchText?: string;
  search?: Search;
  searchResult?: SearchResult;
  environment = environment;

  constructor(private store: Store) {
    this.store
      .select(selectCharacters())
      .pipe(first((characters) => characters && characters.length > 0))
      .subscribe((characters) => {
        const loader = new StoreLoader(characters);
        this.search = new Search(loader);
      });
  }

  filter(): void {
    if (!this.search || !this.searchText) {
      return;
    }

    this.searchResult = this.search.search(this.searchText);
  }
}
class StoreLoader implements Loader {
  constructor(private characters: Character[]) {}
  get data(): Character[] {
    return this.characters;
  }

  async load(): Promise<void> {
    // Not implemented due to it not being needed.
    return;
  }
}
