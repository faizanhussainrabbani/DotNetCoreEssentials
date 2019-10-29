import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})
export class ReviewService {
    public reviews: Review[];
    private baseUrl: string;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        baseUrl = baseUrl;
    }

    // getAllReviews() {
    //     return this.http.get<any[]>(`http://localhost:4000/reviews`);
    // }
    createReview(review) {
        return this.http.post(`http://localhost:4000/reviews/create`, review);
    }
    getAllReviews() {
        return this.http.get<Review[]>('Review/GetAllReviews');
    }
}
