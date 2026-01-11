from datetime import datetime
import requests
import yfinance as yf
#from pandas_datareader import data as wb
import pandas as pd

# Custom Marketstack Reader
class MarketstackReader:
    def __init__(self, symbols, start=None, end=None, api_key=None):
        self.symbols = symbols
        self.start = start
        self.end = end
        self.api_key = api_key

    def read(self):
        url = f"http://api.marketstack.com/v2/eod"
        params = {
            'access_key': self.api_key,
            'symbols': self.symbols,
            'date_from': self.start.strftime("%Y-%m-%d") if self.start else None,
            'date_to': self.end.strftime("%Y-%m-%d") if self.end else None,
        }
        response = requests.get(url, params=params)
        data = response.json()['data']
        df = pd.DataFrame(data)
        df['date'] = pd.to_datetime(df['date'])
        df.set_index('date', inplace=True)
        return df

# api_key = "YOUR_MARKETSTACK_API_KEY"
# reader = MarketstackReader(
#     symbols="AAPL",
#     start=datetime(2023, 1, 1),
#     end=datetime(2023, 1, 31),
#     api_key=api_key
# )

#df = reader.read()
#print(df.head())

PG = yf.download("PG", start="1995-01-01")

tickers = ['PG', 'MSFT', 'T','F','GE']
new_data = pd.DataFrame()

for t in tickers:
    new_data[t] = yf.download(t, start="1995-01-01")['Close']

print(new_data.tail())