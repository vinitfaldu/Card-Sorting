import { Component } from '@angular/core';
import { CardSorterService } from '../../services/card-sorter.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-card-sorter',
  templateUrl: './card-sorter.component.html',
  styleUrls: ['./card-sorter.component.css'] // Fixed property name to "styleUrls"
})
export class CardSorterComponent {
  cardsInput: string = ''; // User input for unsorted cards
  sortedCards: string[] = []; // Sorted cards from API response
  errorMessage: string = ''; // Error message for invalid input or API errors

  constructor(private cardSorterService: CardSorterService, private http: HttpClient) {}

  onSortCards() {
    this.errorMessage = ''; // Reset error message
    const cardsArray = this.cardsInput.split(',').map((card) => card.trim()); // Parse input

    // Validate input: check for empty or invalid entries
    if (cardsArray.some((card) => card === '')) {
      this.errorMessage = 'Please enter valid card strings separated by commas.';
      return;
    }

    // Call the service to sort cards
    this.cardSorterService.sortCards(cardsArray).subscribe({
      next: (sortedCards: string[]) => {
        this.sortedCards = sortedCards; // Bind sorted cards to the UI
      },
      error: (error) => {
        console.error(error);
        this.errorMessage = 'An error occurred while sorting the cards.';
      },
      complete: () => {
        console.info('Card sorting completed.');
      }
    });
  }
}
