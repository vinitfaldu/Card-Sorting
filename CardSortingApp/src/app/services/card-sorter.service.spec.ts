import { TestBed } from '@angular/core/testing';

import { CardSorterService } from './card-sorter.service';

describe('CardSorterService', () => {
  let service: CardSorterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CardSorterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
