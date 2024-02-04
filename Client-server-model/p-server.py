from http.server import BaseHTTPRequestHandler, HTTPServer
import threading
import time
import requests

host_name = "localhost"
server_port = 8080

class Server(BaseHTTPRequestHandler):
    def do_GET(self):
        self.send_response(200)
        self.end_headers()
        self.wfile.write(bytes("""{
            "name": "Python Server",
            "response": "Res"
        }""", "utf-8"))

def run_server():
    web_server = HTTPServer((host_name, server_port), Server)
    print(f"Server started http://{host_name}:{server_port}")
    
    try:
        web_server.serve_forever()
    except KeyboardInterrupt:
        pass

    web_server.server_close()
    print("Server stopped.")        

def run_task():
    print("Task started")
    while True:
        time.sleep(1)
        response = requests.get("http://localhost:8080")
        data = response.json()
        print(f"Name: {data['name']}, response: {data['response']}")

if __name__ == "__main__":    
    serverThread = threading.Thread(target=run_server, daemon=False)
    taskThread = threading.Thread(target=run_task, daemon=True)
    serverThread.start()
    taskThread.start()
    